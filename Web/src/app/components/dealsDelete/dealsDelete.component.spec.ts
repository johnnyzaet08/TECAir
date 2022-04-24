import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DealsDeleteComponent } from './dealsDelete.component';

describe('DealsDeleteComponent', () => {
  let component: DealsDeleteComponent;
  let fixture: ComponentFixture<DealsDeleteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DealsDeleteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DealsDeleteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
