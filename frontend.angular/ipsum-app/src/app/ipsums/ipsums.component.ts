import { Component, OnInit } from '@angular/core';
import { Ipsum } from '../ipsum';
import { Ipsums } from '../mock-ipsums';

@Component({
  selector: 'app-ipsums',
  templateUrl: './ipsums.component.html',
  styleUrls: ['./ipsums.component.css']
})
export class IpsumsComponent implements OnInit {

  ipsums : Ipsum[] = Ipsums;

  constructor() { }

  ngOnInit() {
  }

}
