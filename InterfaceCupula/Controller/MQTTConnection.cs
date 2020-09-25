using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MQTTnet.Client;
using MQTTnet;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Options;
using MQTTnet.Formatter;
using MQTTnet.Server;
using InterfaceCupula.View;
using InterfaceCupula;
using MQTTnet.Client.Receiving;

namespace InterfaceCupula.Controller
{
    class MQTTConnection
    {

        MqttFactory factory = new MqttFactory();
        IMqttClient mqttclient;
        System.Threading.CancellationToken cancellationToken;           //connect to the broker

        string inversorText;
        string server;
        string topic;
        int port;

        public MQTTConnection(ref string text)
        {
            inversorText = text;
        }

        public async void StartConnection(string server, int port, string topic)
        {

 
            var options = new MqttClientOptionsBuilder()
                .WithClientId("clientId-l1OXj2ii5Y")
                .WithTcpServer(server, port)
                .Build();

            this.server = server;
            this.port   = port;
            this.topic  = topic;
            //   client = new MqttFactory().

            mqttclient = factory.CreateMqttClient();

            await mqttclient.ConnectAsync(options, cancellationToken);


            await mqttclient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic(topic).Build());

        
            mqttclient.UseApplicationMessageReceivedHandler(e =>
            {
                inversorText = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                Task.Run(() => mqttclient.PublishAsync("hello/world"));
            });
        
        }
        
        public async Task PublishAsync(string payload)
        {
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(topic)
                .WithPayload(payload)
                .WithAtMostOnceQoS()
                .WithRetainFlag(false)
                .Build();

            await mqttclient.PublishAsync(message, cancellationToken);
        } 
      
    }
}
