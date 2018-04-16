import { DispatcherTemplatePage } from './app.po';

describe('Dispatcher App', function() {
  let page: DispatcherTemplatePage;

  beforeEach(() => {
    page = new DispatcherTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
