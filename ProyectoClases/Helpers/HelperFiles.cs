﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        //private string path;

        //public HelperFiles(string path) { 
        //}

        public static async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            using(TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }

        public static async Task WriteFileAsync(string path,string data)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText()) 
            {
                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();
            }
        }
    }
}
