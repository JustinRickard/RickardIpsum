import { Component, OnInit } from '@angular/core';
import { Ipsum } from '../ipsum';
import { Ipsums } from '../mock-ipsums';

@Component({
  selector: 'app-ipsums',
  templateUrl: './ipsums.component.html',
  styleUrls: ['./ipsums.component.css']
})
export class IpsumsComponent implements OnInit {

  selectedIpsum : Ipsum;
  ipsums : Ipsum[] = Ipsums;

  constructor() { }

  ngOnInit() {
  }

  onSelect(ipsum: Ipsum): void {
    this.selectedIpsum = ipsum;
  }

}
