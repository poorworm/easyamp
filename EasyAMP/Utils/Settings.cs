using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace EasyAMP.Utils
{
    public class Settings
    {
        public static void saveSettings(ConfigObject configObject)
        {
            string jstr = JsonSerializer.Serialize<ConfigObject>(configObject);
            System.IO.File.WriteAllText("settings.json", jstr);

        }

        public static void loadSettings(out ConfigObject configObject)
        {
            string jstr = System.IO.File.ReadAllText("settings.json");
            configObject = JsonSerializer.Deserialize<ConfigObject>(jstr);
        }

        public static void saveHosts(ConfigObject configObject)
        {
            using (StreamWriter w = File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers\\etc\\hosts")))
            {
                foreach(var host in configObject.hosts)
                {
                    w.WriteLine(host.ip + "         " + host.host);
                }
                w.Flush();
            }
        }

        public static void saveVHostConfig(ConfigObject configObject)
        {
            string vhost_conf_file = configObject.xamppPath + @"\apache\conf\extra\httpd-vhosts.conf";

            using (StreamWriter w = File.CreateText(vhost_conf_file))
            {
                string host_block =
                    "NameVirtualHost *:80" + "\n" +
                    "<VirtualHost *:80>" + "\n" +
                        "\tDocumentRoot \"##\\htdocs\"" + "\n" +
                        "\tServerName localhost" + "\n" +
                        "\tServerAlias localhost" + "\n" +
                    "</VirtualHost>" + "\n";

                string vh_block =
                    "<VirtualHost *:80>" + "\n" +
                        "\t<Directory ##\\htdocs\\!!>" + "\n" +
                            "\t\tOrder allow,deny" + "\n" +
                            "\t\tAllow from all" + "\n" +
                        "\t</Directory>" + "\n" +
                        "\tDocumentRoot \"##\\htdocs\\!!\"" + "\n" +
                        "\tServerName !!" + "\n" +
                        "\tServerAlias !!" + "\n" +
                    "</VirtualHost>" +"\n";

                host_block = host_block.Replace("##", configObject.xamppPath);
                vh_block = vh_block.Replace("##", configObject.xamppPath);

                w.Write(host_block);

                foreach (var host in configObject.hosts)
                {
                    if(host.host != "localhost")
                    {
                        string new_vh_block = vh_block.Replace("!!", host.host);
                        w.Write(new_vh_block);

                        // 資料夾
                        if (!System.IO.Directory.Exists(configObject.xamppPath + "\\htdocs\\" + host.host))
                        {
                            System.IO.Directory.CreateDirectory(configObject.xamppPath + "\\htdocs\\" + host.host);
                            System.IO.File.Copy("pi.php", configObject.xamppPath + "\\htdocs\\" + host.host + "\\pi.php");
                        }
                    }
                }
                w.Flush();
            }
        }

        public static void SetPhpStormPrjFile(ConfigObject configObject, string prj_name)
        {
            string xml_path = string.Format("{0}\\htdocs\\{1}\\.idea\\workspace.xml", configObject.xamppPath, prj_name);

            string all_str = System.IO.File.ReadAllText(xml_path);
            all_str = all_str.Replace("demo", prj_name);

            System.IO.File.WriteAllText(xml_path, all_str);
        }
    }
}
