
//Example for OnChanges  LIFECYCLE_HOOKS

import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-simple',
  templateUrl: './simple.component.html',
  styleUrls: ['./simple.component.css']
})
export class SimpleComponent implements OnInit, OnChanges {
  @Input() simpleInput: string;

  ngOnChanges(changes: SimpleChanges): void {
    for (let propertyName in changes) {
      let change = changes[propertyName];
      let current = JSON.stringify(change.currentValue);
      let previous = JSON.stringify(change.previousValue);
      console.log(propertyName + ': currentValue = ' + current + ': previousValue = ' + previous);
    }
  }
  constructor() { }

  ngOnInit() {
  }

}
