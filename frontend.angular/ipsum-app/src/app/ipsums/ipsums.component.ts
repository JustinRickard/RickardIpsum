import { Component, OnInit } from '@angular/core';
import { Ipsum } from '../ipsum';

@Component({
  selector: 'app-ipsums',
  templateUrl: './ipsums.component.html',
  styleUrls: ['./ipsums.component.css']
})
export class IpsumsComponent implements OnInit {

  ipsum : Ipsum = {
    id: 1,
    name: 'Ipsum One'
  };

  constructor() { }

  ngOnInit() {
    
  }

}
