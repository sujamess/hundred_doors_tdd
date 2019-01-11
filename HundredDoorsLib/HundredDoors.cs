using System;
using System.Linq;

namespace HundredDoorsLib {
    public enum DoorState {
        IsOpened, IsClosed
    }

    public class HundredDoors {
        public DoorState[] Toggle(DoorState[] doors, int visitTime) {
            var toggledDoors = new DoorState[doors.Count()];

            for (int i = 0; i < doors.Count(); i++) {
                if ((i + 1) % visitTime == 0) {
                    toggledDoors[i] = doors[i] == DoorState.IsClosed?
                    DoorState.IsOpened : DoorState.IsClosed;
                } else {
                    toggledDoors[i] = doors[i];
                }
            }

            return toggledDoors;
        }

        // public DoorState[] ToggleFirstTime(DoorState[] doors) {
        //     var toggledDoors = new DoorState[doors.Count()];

        //     for (int i = 0; i < doors.Count(); i++) {
        //         toggledDoors[i] = doors[i] == DoorState.IsClosed?
        //             DoorState.IsOpened : DoorState.IsClosed;
        //     }

        //     return toggledDoors;
        // }

        // public DoorState[] ToggleSecondTime(DoorState[] doors) {
        //     var toggledDoors = new DoorState[doors.Count()];

        //     for (int i = 0; i < doors.Count(); i++) {
        //         if ((i + 1) % 2 == 0) {
        //             toggledDoors[i] = doors[i] == DoorState.IsClosed?
        //             DoorState.IsOpened : DoorState.IsClosed;
        //         } else {
        //             toggledDoors[i] = doors[i];
        //         }
        //     }

        //     return toggledDoors;
        // }

        // public DoorState[] ToggleThirdTime(DoorState[] doors)
        // {
        //     var toggledDoors = new DoorState[doors.Count()];

        //     for (int i = 0; i < doors.Count(); i++) {
        //         if ((i + 1) % 3 == 0) {
        //             toggledDoors[i] = doors[i] == DoorState.IsClosed?
        //             DoorState.IsOpened : DoorState.IsClosed;
        //         } else {
        //             toggledDoors[i] = doors[i];
        //         }
        //     }

        //     return toggledDoors;
        // }
    }
}
