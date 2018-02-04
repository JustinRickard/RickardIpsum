import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IpsumDetailComponent } from './ipsum-detail.component';

describe('IpsumDetailComponent', () => {
  let component: IpsumDetailComponent;
  let fixture: ComponentFixture<IpsumDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IpsumDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IpsumDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
