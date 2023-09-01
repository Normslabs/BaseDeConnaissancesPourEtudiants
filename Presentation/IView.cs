using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeConnaissancesEtudiants.Presentation;
internal interface IView<TContent> : NSAIL.ApplicationComponents.IView {

    void Render(TContent contentObject);

}
