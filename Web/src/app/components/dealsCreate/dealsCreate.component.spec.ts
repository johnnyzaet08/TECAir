import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DealsCreateComponent } from './dealsCreate.component';

describe('DealsCreateComponent', () => {
  let component: DealsCreateComponent;
  let fixture: ComponentFixture<DealsCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DealsCreateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DealsCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
