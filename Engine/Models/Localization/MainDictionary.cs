using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Engine.Models.Localization
{
    public static class MainDictionary
    {
        public static readonly Dictionary<string, string> MessageCode = new Dictionary<string, string>
        {
            ["MENU_CHANGED"] = "Меню изменено",
            ["MENU_ADD"] = "Меню добавлено",
            ["MENU_DELETE"] = "Меню удалено",
            ["MENU_TITLE_EMPTY"] = "Необходимо заполнить наименование меню",
            ["POSITION_EMPTY"] = "Не выбрана позиция",
            ["TITLE_EMPTY"] = "Необходимо заполнить наименование",
            ["LINK_EMPTY"] = "Ссылка не заполнена",
            ["SELECT_OBJ_TO_DELETE"] = "Необходимо выбрать объекты для удаления",
            ["PUBLISH"] = "Публикация выполнена",
            ["UNPUBLISH"] = "Cнято с публикации",
            ["DELETE_ATTENTION"] = "Внимание",
            ["DELETE_MESSAGE"] = "Подтвердите удаление",
            ["DELETE_YES"] = "Удалить",
            ["DELETE_CANCEL"] = "Отмена"
        };
    }
}
