using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Chapter04
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //initialiser flux en écriture
            StreamWriter sw = File.CreateText("log.txt");
            //initialiser trace 
            TextWriterTraceListener txt = new TextWriterTraceListener(sw);
            //ajouter trace dans l'écouteur
            Trace.Listeners.Add(txt);
            Trace.AutoFlush = true;
            Debug.WriteLine("Debug I am watching");
            Trace.WriteLine("Trace I am watching");
            Console.WriteLine("Hello World!");

            //Initialisation builder appsettings.json
            var builder = new ConfigurationBuilder().SetBasePath(
                Directory.GetCurrentDirectory()).AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
            
            //Définition configuratinon
            IConfigurationRoot configuration = builder.Build();
            
            //Définition traceSwitch lecture de packtSwitch dans le fichier appSettings.json
            var ts = new TraceSwitch(displayName: "PacktSwitch", description: "This switch is set via a JSON config.");
            
            configuration.GetSection("PacktSwitch").Bind(ts);
            
            Trace.WriteLineIf(ts.TraceError, "Trace error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace information");

        }
    }
}
