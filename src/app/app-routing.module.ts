import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { NaviresListComponent } from './components/navires-list/navires-list.component';
import { NavireDetailsComponent } from './components/navire-details/navire-details.component';
import { AddNavireComponent } from './components/add-navire/add-navire.component';

const routes: Routes = [
 // { path: '', redirectTo: 'products', pathMatch: 'full' },
 { path: '', redirectTo: 'navires', pathMatch: 'full' },
 { path: 'navires', component: NaviresListComponent },
 { path: 'navires/:id', component: NavireDetailsComponent },
 { path: 'add', component: AddNavireComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
