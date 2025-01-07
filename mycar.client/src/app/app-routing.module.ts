import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VehicleFormComponent } from './components/vehicle-form/vehicle-form.component';
import { HomeComponent } from './components/home/home.component';
import { VehicleListComponent } from './components/vehicle-list/vehicle-list.component';

const routes: Routes = [
  { path: '', redirectTo: 'vehicles', pathMatch: 'full' },
  { path: 'vehicles/new', component: VehicleFormComponent },
  { path: 'vehicles/:id', component: VehicleFormComponent },
  { path: 'vehicles', component: VehicleListComponent },
  { path: 'home', component: HomeComponent },
  { path: '**', redirectTo: 'home' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
