import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }


  public decrementCounter() {
    this.currentCount--;
  }

  public newCount(num: string) {

    if (isNaN(+num)) {
      this.currentCount = 15;

    }else {

      this.currentCount = +num;
    }
  }

}

