import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { IpsumsComponent } from './ipsums/ipsums.component';
import { FormsModule } from '@angular/forms';
import { IpsumDetailComponent } from './ipsum-detail/ipsum-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    IpsumsComponent,
    IpsumDetailComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
