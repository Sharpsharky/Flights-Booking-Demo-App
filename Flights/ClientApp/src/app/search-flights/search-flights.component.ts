import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-search-flights',
  templateUrl: './search-flights.component.html',
  styleUrls: ['./search-flights.component.css']
})
export class SearchFlightsComponent implements OnInit{

  searchResult: FlightRm[] = [
    {
      airline: "Buzz",
      remainingNumberOfSeats: 12,
      arrival: { time: Date.now().toString(), place: "Berlin" },
      departure: { time: Date.now().toString(), place: "Istanbul" },
      price:340,
    },
    {
      airline: "Ryanair",
      remainingNumberOfSeats: 3,
      arrival: { time: Date.now().toString(), place: "Wrocław" },
      departure: { time: Date.now().toString(), place: "Nicosia" },
      price: 70,
    },
    {
      airline: "Wizzair",
      remainingNumberOfSeats: 5,
      arrival: { time: Date.now().toString(), place: "Lisona" },
      departure: { time: Date.now().toString(), place: "Warsaw" },
      price: 110,
    },
    {
      airline: "Lufthansa",
      remainingNumberOfSeats: 1,
      arrival: { time: Date.now().toString(), place: "Munchen" },
      departure: { time: Date.now().toString(), place: "Stockholm" },
      price: 290,
    },
  ]

  constructor() { }

  ngOnInit(): void {
  }

}

export interface FlightRm {
  airline: string
  arrival: TimePlaceRm
  departure: TimePlaceRm
  price: number
  remainingNumberOfSeats: number
}

export interface TimePlaceRm {
  place: string;
  time: string;
}
