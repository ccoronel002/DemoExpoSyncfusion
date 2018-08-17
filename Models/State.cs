﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJ2MVCSampleBrowser.Models
{
    public class State
    {
        public string StateName { get; set; }
        public string CountryId { get; set; }
        public string StateId { get; set; }
        public List<State> StateList()
        {
            List<State> state = new List<State>();
            state.Add(new State() { StateName = "New York", CountryId = "1", StateId = "101" });
            state.Add(new State() { StateName = "San José", CountryId = "2", StateId = "104" });
            state.Add(new State() { StateName = "Cartago ", CountryId = "2", StateId = "105" });
            state.Add(new State() { StateName = "Heredia", CountryId = "2", StateId = "106" });
            state.Add(new State() { StateName = "Virginia ", CountryId = "1", StateId = "102" });
            state.Add(new State() { StateName = "Washington", CountryId = "1", StateId = "103" });
            return state;
        }
    }
}