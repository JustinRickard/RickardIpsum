import { TestBed, inject } from '@angular/core/testing';

import { IpsumService } from './ipsum.service';

describe('IpsumService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [IpsumService]
    });
  });

  it('should be created', inject([IpsumService], (service: IpsumService) => {
    expect(service).toBeTruthy();
  }));
});
