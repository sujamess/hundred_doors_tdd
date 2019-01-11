using System;
using System.Linq;
using HundredDoorsLib;
using Xunit;

namespace HundredDoorsTests {
    public class Constant {
        public const int numberOfDoors = 100;
    }
    
    public class TestHundredDoors {
        private DoorState[] doors;

        [Fact]
        public void TestHowManyDoorsOpenAndClose() {
            HundredDoorsInARowAreAllInitiallyClosed();
            TheFirstTimeYouVisitEveryDoorAndToggleTheDoor();
            TheSecondTimeYouOnlyVisitEvery2ndDoor();
            TheThirdTimeEvery3rdDoor();
        }

        private void HundredDoorsInARowAreAllInitiallyClosed() {
            doors = new DoorState[Constant.numberOfDoors];

            for (int i = 0; i < Constant.numberOfDoors; i++) {
                doors[i] = DoorState.IsClosed;
            }

            Assert.Equal(Constant.numberOfDoors, doors.Count());
        }

        private void TheFirstTimeYouVisitEveryDoorAndToggleTheDoor() {
            HundredDoors hundredDoors = new HundredDoors();

            doors = hundredDoors.Toggle(doors, 1);

            for (int i = 0; i < Constant.numberOfDoors; i++) {
                Assert.Equal(DoorState.IsOpened, doors[i]);
            }
        }

        private void TheSecondTimeYouOnlyVisitEvery2ndDoor() {
            HundredDoors hundredDoors = new HundredDoors();

            doors = hundredDoors.Toggle(doors, 2);

            for (int i = 0; i < doors.Count(); i++) {
                if ((i + 1) % 2 == 0) {
                    Assert.Equal(DoorState.IsClosed, doors[i]);
                }
            }
        }

        private void TheThirdTimeEvery3rdDoor() {
            HundredDoors hundredDoors = new HundredDoors();

            doors = hundredDoors.Toggle(doors, 3);
            var openDoors = from door in doors
                            where door == DoorState.IsOpened
                            select door;
            var closeDoors = from door in doors
                             where door == DoorState.IsClosed
                             select door;

            Assert.Equal(49, openDoors.Count());
            Assert.Equal(51, closeDoors.Count());
        }
    }
}
