﻿namespace RoomReservationWPF.Models
{
    using System;
    using System.Collections.Generic;

    internal class Scheduler_deprecated
    {
        private Dictionary<Room, HashSet<Timeslot>> roomSchedule;

        // or beter yet, hashset of timeslots
        public Scheduler_deprecated()
        {
            this.roomSchedule = new Dictionary<Room, HashSet<Timeslot>>();
        }

        public bool CheckSlot(int roomID, DateTime date)
        {
            return false;
        }

        public List<Room> GetFreeSlotsForADate(int roomId, DateTime date)
        {
            return null;
        }

        // iterate rooms by roomID and slot and get the most relevant 
        // sortthe result (using linq) by distance
        /* - some search method will be needed;
- bool checkSlot(roomId, slot, (Date)) – informs if a room is free during a certain time slot;
- getFreeSlotsForADate(roomId,(Date)) – returns all free timeslots for a room for a given date;
- getFreeSlots(roomId) - all free timeslots for a room;
- getFreeRooms(Date) – returns all free room Id’s and the corresponding slots;
         */
    }
}
