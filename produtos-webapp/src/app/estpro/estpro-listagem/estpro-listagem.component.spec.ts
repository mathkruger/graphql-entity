import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EstproListagemComponent } from './estpro-listagem.component';

describe('EstproListagemComponent', () => {
  let component: EstproListagemComponent;
  let fixture: ComponentFixture<EstproListagemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EstproListagemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EstproListagemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
