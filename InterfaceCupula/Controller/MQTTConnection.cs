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

        string msg;
        string server;
        string topic;
        int port;
        bool newMessageFlag = true;

        public async void StartConnection(string server, int port, string topic)
        {

 
            var options = new MqttClientOptionsBuilder()
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
                msg = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                newMessageFlag = !newMessageFlag;
                Task.Run(() => mqttclient.PublishAsync("hello/world"));
            });
        
        }
        
        public bool getMessageFlag()
        {
            return newMessageFlag;
        }

        public string getMsg()
        {
            return msg;
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
