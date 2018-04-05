import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RedeemCuponComponent } from './redeem-cupon.component';

describe('RedeemCuponComponent', () => {
  let component: RedeemCuponComponent;
  let fixture: ComponentFixture<RedeemCuponComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RedeemCuponComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RedeemCuponComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
