using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Business
{
    public class Occupants
    {
        public OccupantTye Occupant1 { get; set; } = OccupantTye.None;
        public OccupantTye Occupant2 { get; set; } = OccupantTye.None;
        public OccupantTye Occupant3 { get; set; } = OccupantTye.None;
        public OccupantTye Occupant4 { get; set; } = OccupantTye.None;
    }

    // Enum for occupant types
    public enum OccupantTye
    {
        Adult,
        Child,
        Infant,
        None
    }
}
