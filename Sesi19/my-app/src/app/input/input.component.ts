import { Component, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-input',
  templateUrl: './input.component.html',
  styleUrls: ['./input.component.css']
})
export class InputComponent implements OnInit {
  @Output() sendResult = new EventEmitter<number>() 

  constructor() { }

  ngOnInit(): void {
  }

  callIncrementListener(value: string) {
    this.sendResult.emit(parseInt(value))
  }

}
