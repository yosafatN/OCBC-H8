import { Component, Input, OnInit, Output, EventEmitter } from "@angular/core";

@Component({
    selector: 'app-aside',
    templateUrl: './aside.component.html',
    styleUrls: ['./aside.component.css']
})

export class AsideComponent implements OnInit{
    constructor(){}

    people: any[] = [
        {
            name: "Douglas Pace",
            age: 35,
            country: 'MARS'
        },
        {
            name: "Mcleod Mueller",
            age: 32,
            country: 'USA'
        },
        {
            name: "Day Mayers",
            age: 21,
            country: 'HK'
        },
        {
            name: "Aguierre Ellis",
            age: 34,
            country: 'UK'
        },
        {
            name: "Cook Tyson",
            age: 32,
            country: 'USA'
        },
    ]

    getBackgroundColor(person: any) {
        let color = 'black';
        if (person.country == 'UK') {
            color = 'blue'
        }
        else if (person.country == 'USA') {
            color = 'red'
        }
        else if (person.country == 'HK') {
            color = 'green'
        }
        
        return color;
      }

    ngOnInit(): void {
        
    }
}