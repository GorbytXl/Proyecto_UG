import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MedicacitaComponent } from './medicacita.component';

describe('MedicacitaComponent', () => {
  let component: MedicacitaComponent;
  let fixture: ComponentFixture<MedicacitaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MedicacitaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MedicacitaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
