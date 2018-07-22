import { CCodeTemplatePage } from './app.po';

describe('CCode App', function() {
  let page: CCodeTemplatePage;

  beforeEach(() => {
    page = new CCodeTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
