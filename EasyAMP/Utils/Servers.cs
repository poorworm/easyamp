using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceProcess;



namespace EasyAMP.Utils
{
    public class Servers
    {
        public static string GetServiceState(string service_name)
        {
            ServiceController sc = new ServiceController(service_name);

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    return "Running";
                case ServiceControllerStatus.Stopped:
                    return "Stopped";
                case ServiceControllerStatus.Paused:
                    return "Paused";
                case ServiceControllerStatus.StopPending:
                    return "Stopping";
                case ServiceControllerStatus.StartPending:
                    return "Starting";
                default:
                    return "Status Changing";
            }
        }

        public static void Start(string service_name)
        {

            ServiceController controller = new ServiceController();
            controller.MachineName = ".";
            controller.ServiceName = service_name;
            try
            {
                controller.Start();
            }
            catch(Exception ex)
            {

            }
        }
        public static void Stop(string service_name)
        {
            ServiceController controller = new ServiceController();
            controller.MachineName = ".";
            controller.ServiceName = service_name;

            try
            {
                controller.Stop();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
