using System;

namespace jeniffer.dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeVezes = 5;

            for (int i = 0; i < numeroDeVezes; i++)
            {
                Console.WriteLine($"Bem vindo ao curso de .NET{i}");
            }

            var sqs = new Amazon.SQS.AmazonSQSClient();
            sqs.SendMessageAsync(new Amazon.SQS.Model.SendMessageRequest { MessageBody = "teste" });
        }
    }
}
