﻿using ArtificialNeuralNetwork;
using Newtonsoft.Json;
using System.IO;

namespace NeuralNetwork.GeneticAlgorithm.Utils
{
    public class NeuralNetworkLoader : INeuralNetworkLoader
    {
        private readonly string _directory;

         public NeuralNetworkLoader(string directory)
        {
            _directory = directory;
        }

        public INeuralNetwork LoadNeuralNetwork(string filename)
        {
            var jsonNet = File.ReadAllText(_directory + filename);
            INeuralNetwork network = JsonConvert.DeserializeObject<INeuralNetwork>(jsonNet);
            return network;
        }
    }
}
