using System;
using System.Collections.Generic;

public sealed class PusatDataSingleton
{
    private static PusatDataSingleton instance = null;
    private static readonly object padlock = new object();

    public List<string> DataTersimpan { get; private set; }

    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    public static PusatDataSingleton GetDataSingleton()
    {
        lock (padlock)
        {
            if (instance == null)
            {
                instance = new PusatDataSingleton();
            }
            return instance;
        }
    }

    public void PrintSemuaData()
    {
        foreach (var data in DataTersimpan)
        {
            Console.WriteLine(data);
        }
    }

    public void AddSebuahData(string input)
    {
        DataTersimpan.Add(input);
    }

    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            DataTersimpan.RemoveAt(index);
        }
    }

    public int GetSemuaData()
    {
        return DataTersimpan.Count;
    }
}