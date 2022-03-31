export interface Produto {
    id: number;
    nome: string;
    categoria: string;
    quantidadeEstoque: number;
    quantidadeMinima: number;
    precoCusto: number;
    precoVenda: number;
    pedidos: any;
}
