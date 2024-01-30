import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsComponent } from './components/products/products.component';
import { SuppliersComponent } from './components/suppliers/suppliers.component';
import { TestesComponent } from './components/testes/testes.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    SuppliersComponent,
    TestesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
