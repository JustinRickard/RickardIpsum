import { Component, OnInit } from '@angular/core';
import { Ipsum } from '../ipsum';
import { IpsumService } from '../ipsum.service';

@Component({
  selector: 'app-ipsums',
  templateUrl: './ipsums.component.html',
  styleUrls: ['./ipsums.component.css']
})
export class IpsumsComponent implements OnInit {

  selectedIpsum : Ipsum;
  ipsums : Ipsum[];

  constructor(private ipsumService: IpsumService) { }

  ngOnInit() {
    this.getIpsums();
  }

  onSelect(ipsum: Ipsum): void {
    this.selectedIpsum = ipsum;
  }

  getIpsums(): void {
    this.ipsums = this.ipsumService.getIpsums();
  }

}
