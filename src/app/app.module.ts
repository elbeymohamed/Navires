import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddNavireComponent } from './components/add-navire/add-navire.component';
import { ProductDetailsComponent } from './components/navire-details/product-details.component';
import { NaviresListComponent } from './components/navires-list/navires-list.component';

import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    AppComponent,
    AddNavireComponent,
    NaviresListComponent,
    NaviresListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
