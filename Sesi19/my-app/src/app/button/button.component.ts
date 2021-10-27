import { Component, Input, Output, EventEmitter, OnInit } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent {

  constructor() { }

  @Output() clickEventListener = new EventEmitter()
  @Output() resetListener = new EventEmitter()
  @Input() buttonNameSubmit = ''
  @Input() buttonNameReset = ''

  callClickEventListener() {
    this.clickEventListener.emit()
  }

  callReset() {
    this.resetListener.emit()
  }
}
