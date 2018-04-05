import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { RedeemCuponComponent } from './components/redeem-cupon/redeem-cupon.component';
import { CustomerFormComponent } from './components/customer-form/customer-form.component';


@NgModule({
  declarations: [
    AppComponent,
    RedeemCuponComponent,
    CustomerFormComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
