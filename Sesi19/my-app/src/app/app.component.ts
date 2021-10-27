import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'my-app';
  buttonNameSubmit = 'Submit'
  buttonNameReset = 'Reset'
  counter = 0
  temp = 0

  responseEventListener() {
    this.counter+=this.temp
  }

  responseIncrementChange(value: number) {
    this.temp = value
  }

  resetIncremet () {
    this.counter = 0
  }
}
