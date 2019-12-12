import { AppComponent } from './app.component';
import { EstproListagemComponent } from './estpro/estpro-listagem/estpro-listagem.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
    {
        path: '',
        component: EstproListagemComponent
    },
];

@NgModule({
    declarations: [],
    imports: [RouterModule.forRoot(routes, { useHash: true })],
    exports: [RouterModule]
})
export class AppRoutingModule {

}
