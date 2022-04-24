import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DealsUpdateComponent } from './dealsUpdate.component';

describe('DealsUpdateComponent', () => {
  let component: DealsUpdateComponent;
  let fixture: ComponentFixture<DealsUpdateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DealsUpdateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DealsUpdateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
