using BlazorServerLibrary.Enums;
using BlazorServerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerLibrary.Models.Doors
{
    public class PedestrianDoor : Door
    {
        public ElectricalEntry ElectricalEntry { get;set; }
        public FireDefence FireDefence { get; set; }
        public bool IsFireEscape { get; set; }

        [MaxLength(50)]
        public string HandleType { get; set; }
        public bool IsCloser { get; set; }
        public bool IsElectricalEntry { get; set; }
        public bool IsMagLock { get; set; }
        public int NumberOfLockingPoints { get; set; }
        public double SizeOverStandardHeight { get; set; }
        public double SizeOverStandardWidth { get; set; }
    }
}
