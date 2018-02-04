import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IpsumsComponent } from './ipsums.component';

describe('IpsumsComponent', () => {
  let component: IpsumsComponent;
  let fixture: ComponentFixture<IpsumsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IpsumsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IpsumsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
