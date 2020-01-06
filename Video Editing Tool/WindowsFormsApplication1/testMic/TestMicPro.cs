using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;



class ListenerThreadState
{
    public IPEndPoint EndPoint { get; set; }
    //public INetworkChatCodec Codec { get; set; }
}
/// <summary>
/// Test microphone
/// </summary>
public class TestMicPro
{
    private WaveIn waveIn;
    private UdpClient udpSender;
    private UdpClient udpListener;
    private IWavePlayer waveOut;
    private BufferedWaveProvider waveProvider;
    //private INetworkChatCodec selectedCodec;
    private volatile bool connected;


    public int port { set; get; }
    private string ip { set; get; }
    private int inputDeviceNumber;

    public TestMicPro(int inputDeviceNumber,int port)
    {
        ip = "127.0.0.1";
        this.inputDeviceNumber = inputDeviceNumber;
        this.port = port;
     //   this.selectedCodec = new NarrowBandSpeexCodec();
    }

    public void connect()
    {
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
        Connect(endPoint, inputDeviceNumber);

    }


    private void Connect(IPEndPoint endPoint, int inputDeviceNumber)
    {
        waveIn = new WaveIn();
        waveIn.BufferMilliseconds = 50;
        waveIn.DeviceNumber = inputDeviceNumber;
        waveIn.WaveFormat = new WaveFormat(8000, 16, 1);
        waveIn.DataAvailable += waveIn_DataAvailable;
        waveIn.StartRecording();

        udpSender = new UdpClient();
        udpListener = new UdpClient();

        udpListener.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        udpListener.Client.Bind(endPoint);

        udpSender.Connect(endPoint);

        waveOut = new WaveOut();
        waveProvider = new BufferedWaveProvider(new WaveFormat(8000, 16, 1));
        waveOut.Init(waveProvider);
        waveOut.Play();

        connected = true;
        var state = new ListenerThreadState { EndPoint = endPoint };
        ThreadPool.QueueUserWorkItem(ListenerThread, state);
    }

    private void ListenerThread(object state)
    {
        var listenerThreadState = (ListenerThreadState)state;
        var endPoint = listenerThreadState.EndPoint;
        try
        {
            while (connected)
            {
                byte[] b = udpListener.Receive(ref endPoint);
          //      byte[] decoded = listenerThreadState.Codec.Decode(b, 0, b.Length);
                waveProvider.AddSamples(b, 0, b.Length);
            }
        }
        catch (SocketException)
        {
            // usually not a problem - just means we have disconnected
        }
    }

    void waveIn_DataAvailable(object sender, WaveInEventArgs e)
    {

     //   byte[] encoded = selectedCodec.Encode(, 0, e.BytesRecorded);
        udpSender.Send(e.Buffer, e.Buffer.Length);
    }


    public void Disconnect()
    {
        if (connected)
        {
            connected = false;
            waveIn.DataAvailable -= waveIn_DataAvailable;
            waveIn.StopRecording();
            waveOut.Stop();

            udpSender.Close();
            udpListener.Close();
            waveIn.Dispose();
            waveOut.Dispose();
        }
    }
}
