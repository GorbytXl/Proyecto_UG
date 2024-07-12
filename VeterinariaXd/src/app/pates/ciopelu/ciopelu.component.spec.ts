import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CiopeluComponent } from './ciopelu.component';

describe('CiopeluComponent', () => {
  let component: CiopeluComponent;
  let fixture: ComponentFixture<CiopeluComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CiopeluComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CiopeluComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
