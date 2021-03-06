import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'client';
  stocks: any;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getStocks();
  }

  getStocks() {
    this.http.get("http://localhost:5000/api/Stocks").subscribe(response => {
      this.stocks = response;
    }, error => {
      console.log(error);
    });
  }
}
