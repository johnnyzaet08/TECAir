import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Deals2Component } from './deals2.component';

describe('Deals2Component', () => {
  let component: Deals2Component;
  let fixture: ComponentFixture<Deals2Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Deals2Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Deals2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
