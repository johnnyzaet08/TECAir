import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddbagComponent } from './addbag.component';

describe('AddflightComponent', () => {
  let component: AddbagComponent;
  let fixture: ComponentFixture<AddbagComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AddbagComponent],
    }).compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddbagComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
