import { Injectable } from '@angular/core';
import { Ipsum } from './ipsum';
import { Ipsums } from './mock-ipsums';

@Injectable()
export class IpsumService {

  constructor() { }

  getIpsums(): Ipsum[] {
    return Ipsums;
  }

}
