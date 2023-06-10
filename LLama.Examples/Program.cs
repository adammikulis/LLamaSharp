﻿using LLama;
using LLama.Abstractions.Params;
using LLama.Examples;
using LLama.Examples.Old;

Console.WriteLine("======================================================================================================");

Console.WriteLine(" __       __                                       ____     __                                  \r\n/\\ \\     /\\ \\                                     /\\  _`\\  /\\ \\                                 \r\n\\ \\ \\    \\ \\ \\         __       ___ ___       __  \\ \\,\\L\\_\\\\ \\ \\___       __     _ __   _____   \r\n \\ \\ \\  __\\ \\ \\  __  /'__`\\   /' __` __`\\   /'__`\\ \\/_\\__ \\ \\ \\  _ `\\   /'__`\\  /\\`'__\\/\\ '__`\\ \r\n  \\ \\ \\L\\ \\\\ \\ \\L\\ \\/\\ \\L\\.\\_ /\\ \\/\\ \\/\\ \\ /\\ \\L\\.\\_ /\\ \\L\\ \\\\ \\ \\ \\ \\ /\\ \\L\\.\\_\\ \\ \\/ \\ \\ \\L\\ \\\r\n   \\ \\____/ \\ \\____/\\ \\__/.\\_\\\\ \\_\\ \\_\\ \\_\\\\ \\__/.\\_\\\\ `\\____\\\\ \\_\\ \\_\\\\ \\__/.\\_\\\\ \\_\\  \\ \\ ,__/\r\n    \\/___/   \\/___/  \\/__/\\/_/ \\/_/\\/_/\\/_/ \\/__/\\/_/ \\/_____/ \\/_/\\/_/ \\/__/\\/_/ \\/_/   \\ \\ \\/ \r\n                                                                                          \\ \\_\\ \r\n                                                                                           \\/_/ ");

Console.WriteLine("======================================================================================================");



Console.WriteLine();

Console.WriteLine("Please choose the version you want to test: ");
Console.WriteLine("0. old version (for v0.3.0 or earlier version)");
Console.WriteLine("1. new version (for versions after v0.4.0)");

Console.Write("\nYour Choice: ");
int version = int.Parse(Console.ReadLine());
Console.WriteLine();

if(version == 1)
{
    Console.WriteLine("The examples for new versions are under working now. We'll soon update the examples." +
        " Thank you for your support!");
    string modelPath = "D:\\development\\llama\\weights\\wizard-vicuna-13B.ggmlv3.q4_1.bin";
    var prompt = File.ReadAllText("Assets/dan.txt").Trim();
    LLamaInstructExecutor ex = new(new LLamaModel(new ModelParams(modelPath, contextSize: 1024)));

    while (true)
    {
        foreach (var text in ex.Infer(prompt, new SessionParams() { Temperature = 0.6f }))
        {
            Console.Write(text);
        }
        prompt = Console.ReadLine();
    }
}
else
{
    OldTestRunner.Run();
}