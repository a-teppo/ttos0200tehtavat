using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.OO
{
    public class Radio
    {
        private bool on = false;
        private string name;
        private int volume = 0;
        private double channel = 2000.0;

        public string Name { get; }
        public string Model { get; set; }
        public bool On
        {
            get
            {
                return on;
            }
            set
            {
                On = value;
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= 10 && value >= 0) volume = value;
                else
                    volume = 0;
            }
        }
        public double Channel
        {
            get
            {
                return channel;
            }
            set
            {
                if (value <= 26000.0 && value >= 2000.0) channel = value;
                else
                    channel = 2000.0;
            }
        }

        public Radio(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public bool ToOn(bool changeOn)
        {
            on = changeOn;
            return on;
        }

        public int ChangeVolume(int changeVolume)
        {
            Volume = changeVolume;
            return Volume;
        }

        public double ChangeChannel(double changeChannel)
        {
            Channel = changeChannel;
            return Channel;
        }


        public override string ToString()
        {
            return $"Name: {Name}, Model: {Model}, On: {On}, Volume: {Volume}, Channel: {Channel}. ";
        }
    }
}
