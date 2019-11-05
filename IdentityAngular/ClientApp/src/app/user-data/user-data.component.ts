import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user-data',
  templateUrl: './user-data.component.html'
})
export class UserDataComponent {
    public userOrder: UserOrder[];

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      http.get<UserOrder[]>(baseUrl + 'userorder').subscribe(result => {
      this.userOrder = result;
    }, error => console.error(error));
  }
}

interface UserOrder {
  title: string;
  dateofpurchase: string;
  totlalamount: number;
  status: boolean;
}
