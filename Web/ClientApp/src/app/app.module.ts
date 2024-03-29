// Faz a definição de localidade permitando a formatação 1.2 de moeda brasileira ex: 1,00, 50.00, 1.000, 1.500,50
import { registerLocaleData } from '@angular/common';
import localePt from '@angular/common/locales/pt';
import { TooltipModule } from 'ngx-bootstrap/tooltip';

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/initial/home.component';
import { NavComponent } from './components/nav/nav.component';
import { ProductsComponent } from './components/products/products.component';
import { SuppliersComponent } from './components/suppliers/suppliers.component';
import { TestesComponent } from './components/testes/testes.component';
import { DateFormatPipe } from './helpers/Dates/date-format.pipe';
import { DateTimeFormatPipe } from './helpers/Dates/date-time-format.pipe';
import { ProductService } from './services/product.service';

registerLocaleData(localePt);

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    SuppliersComponent,
    TestesComponent,
    NavComponent,
    HomeComponent,
    DateTimeFormatPipe,
    DateFormatPipe,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    CollapseModule.forRoot(),
    TooltipModule.forRoot(),
    BsDropdownModule.forRoot(),
  ],
  providers: [ProductService],
  bootstrap: [AppComponent],
})
export class AppModule {}
