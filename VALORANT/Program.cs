using System.Diagnostics;

string command = "C:\\Riot Games\\Riot Client\\RiotClientServices.exe";
string arguements = "--launch-product=valorant --launch-patchline=live";

Process process = new Process();

process.StartInfo.FileName = command;
process.StartInfo.Arguments = arguements;
process.StartInfo.UseShellExecute = false;

Console.WriteLine("Launching Valorant");

process.Start();

Console.WriteLine("Executed launch command");

process.WaitForExit();

