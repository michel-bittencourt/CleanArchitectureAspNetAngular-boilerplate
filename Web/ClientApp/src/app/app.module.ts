// Faz a definição de localidade permitando a formatação 1.2 de moeda brasileira ex: 1,00, 50.00, 1.000, 1.500,50
import { registerLocaleData } from '@angular/common';
import localePt from '@angular/common/locales/pt';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsComponent } from './components/products/products.component';
import { SuppliersComponent } from './components/suppliers/suppliers.component';
import { TestesComponent } from './components/testes/testes.component';
import { NavComponent } from './components/nav/nav.component';
import { HomeComponent } from './components/home/home.component';

registerLocaleData(localePt);

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    SuppliersComponent,
    TestesComponent,
    NavComponent,
    HomeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
