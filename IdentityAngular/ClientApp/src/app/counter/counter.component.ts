import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent {
    public currentCount = 0 || parseInt(localStorage.getItem("IdentityAngular-currentCount") || '0');

    public incrementCounter() {
      this.currentCount++;
      localStorage.setItem("IdentityAngular-currentCount", this.currentCount.toString());
  }
}
