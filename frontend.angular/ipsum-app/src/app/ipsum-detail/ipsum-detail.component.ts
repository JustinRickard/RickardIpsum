import { Component, OnInit, Input } from '@angular/core';
import { Ipsum } from '../ipsum';

@Component({
  selector: 'app-ipsum-detail',
  templateUrl: './ipsum-detail.component.html',
  styleUrls: ['./ipsum-detail.component.css']
})
export class IpsumDetailComponent implements OnInit {

  @Input() ipsum: Ipsum; 

  constructor() { }

  ngOnInit() {
  }

}
